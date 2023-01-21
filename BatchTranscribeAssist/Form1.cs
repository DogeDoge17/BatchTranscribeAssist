using Newtonsoft.Json;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Xml.Linq;

namespace BatchTranscribeAssist
{
    public partial class Form1 : Form
    {
        private string _folderPath = "";
        private string _filePath = "";

        private List<AudioInfo> _audioInfos = new List<AudioInfo>();
        private List<SoundPlayer>? _audio = new List<SoundPlayer>();
        private List<string> _content = new List<string>();
        private string[] files;


        private string _rawData = "";

        private int _index = 0;

        private string _currentFileName { get { return Path.GetFileName(files[_index]); } set { } }
        private string _currentContent { get { return _content[_index]; } set { } }

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(900, 484);
            pictureBox1.BackColor = BackColor;
        }


        private void SetSpot(int ind, int of)
        {
            var foo = statusLbl.Text.Split("\n");

            var builder = new StringBuilder();
            builder.Append($"{foo[0]}\n");
            builder.Append($"{ind}/{of}");

            statusLbl.Text = builder.ToString();
        }

        private void SetFile(string name)
        {
            var foo = statusLbl.Text.Split("\n");

            var builder = new StringBuilder();
            builder.Append($"{name}\n");
            builder.Append(foo[1]);


            statusLbl.Text = builder.ToString();
        }

        private void SaveToFile(int index, string fileName, string content)
        {
            _audioInfos[index] = new(index, fileName, content);


            var json = JsonConvert.SerializeObject(_audioInfos, Formatting.Indented);

            File.WriteAllText(_filePath, json);
        }

        private void folderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                _folderPath = folderDialog.SelectedPath;
                folderLbl.Text = $"{_folderPath}";

                {   //this is so the stuff is sorted correctly for my use case. im pretty sure it would break if i didnt put this guard here but im keeping this in the code becaues i made it for myself
                    int specific = 0;

                    if (specific == 0)
                    {
                        files = Directory.GetFiles(_folderPath, "*.wav", SearchOption.AllDirectories);
                    }
                    else
                    {
                        var unsorted = Directory.GetFiles(_folderPath, "*.wav", SearchOption.AllDirectories);

                        files = unsorted.OrderBy(x => int.Parse(Path.GetFileNameWithoutExtension(x).Split('[', ']')[1])).ToArray();
                    }
                }

                _audio = new();
                _content = new();

                SetSpot(1, files.Length);
                SetFile(Path.GetFileName(files[0]));


                //_content = new List<string>(files.Length);

                for (int i = 0; i < files.Length; i++)
                {
                    _audio.Add(new SoundPlayer(files[i]));
                }
                _index = 0;
            }
            if (_filePath != "")
            {
                SharedFinishUp();
            }
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "json files (*.json)|*.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    _filePath = openFileDialog.FileName;
                    fileLbl.Text = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        _rawData = reader.ReadToEnd();
                        _audioInfos = JsonConvert.DeserializeObject<List<AudioInfo>>(_rawData);
                    }
                }
            }

            if (_folderPath != "")
            {
                SharedFinishUp();
            }
        }

        private void SharedFinishUp()
        {
            this.pictureBox1.Size = new System.Drawing.Size(10, 484);
            pictureBox1.BackColor = Color.Black;

            if (_audioInfos != null)
            {

                for (int i = _audioInfos.Count; i < files.Length; i++)
                {
                    _audioInfos.Add(new AudioInfo(0, "", ""));
                }

            }
            else
            {
                _audioInfos = new();

                for (int i = _audioInfos.Count; i < files.Length; i++)
                {
                    _audioInfos.Add(new AudioInfo(0, "", ""));
                }
            }

            foreach (var infr in _audioInfos)
            {
                _content.Add(infr.content);
            }

            inputBox.Text = _content[0];
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            _content[_index] = inputBox.Text;
            SaveToFile(_index, _currentFileName, _currentContent);
            if (_index >= files.Length - 1)
            {
                _index = 0;
            }
            else
            {
                _index++;
            }

            SetFile(_currentFileName);
            SetSpot(_index + 1, files.Length);

            inputBox.Text = _content[_index];

        }
        private void previousBtn_Click(object sender, EventArgs e)
        {
            _content[_index] = inputBox.Text;
            SaveToFile(_index , _currentFileName, _currentContent);
            if (_index <= 0)
            {
                _index = files.Length - 1;
            }
            else
            {
                _index--;
            }

            SetFile(_currentFileName);
            SetSpot(_index + 1, files.Length);

            inputBox.Text = _content[_index];
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            _audio[_index].Play();
        }
    }

    class AudioInfo
    {
        [JsonProperty("index")]
        public int index { get; set; }

        [JsonProperty("name")]
        public string? fileName { get; set; }

        [JsonProperty("content")]
        public string? content { get; set; }

        public AudioInfo(int index, string fileName, string content)
        {
            this.index = index;
            this.fileName = fileName;
            this.content = content;
        }
    }
}
