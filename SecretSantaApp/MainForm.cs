using Microsoft.IdentityModel.Tokens;
using SecretSantaApp.DbHelp;
using SecretSantaApp.Properties;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SecretSantaApp
{
    public partial class MainForm : Form
    {

        private static UserContext _context = new();

        private static DbRepository<User> _userHelper = new DbRepository<User>(_context);

        private static List<User> _users = _userHelper.ReadAll();

        private static List<string> _lines = new();

        private static bool _sorted = false;

        private static List<string> UserNames
        {
            get
            {
                List<string> names = new();
                foreach(User e in _users)
                {
                    names.Add(e.Name);
                }
                return names;
            }
        }

        private static User _crntEntity;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            listBoxUsers.DataSource = _users;     //First init
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backgroundPicture.Image = Properties.Resources.MainPagePic;
            lblTitle.Visible = true;
            btnKnowVictim.Visible = true;
            btnFindAll.Visible = true;
            btnShowAllPlayers.Visible = true;
            btnCredits.Visible = true;
            btnBack.Visible = false;
            listBoxUsers.Visible = false;
            listBoxUsers.Enabled = true; 
            lblSelectedName.Visible = false;
            btnDeleteEntity.Visible = false;
            btnRenameEntity.Visible = false;
            lblRenameTipNote.Visible = false;
            textBoxRenameUser.Visible = false;
            btnSaveRename.Visible = false;
            btnAddEntity.Visible = false;
            btnCreateEntity.Visible = false;
            lblEmptyName.Visible = false;
            lblExistingName.Visible = false;
            lblNameInput.Visible = false;
            btnNameInput.Visible = false;
            textBoxNameInput.Visible = false;
            lblVictimName.Visible = false;
            lblVictimTitle.Visible = false;
            listBoxFindAll.Visible = false;
            btnGenerateList.Visible = false;
            btnRefreshFindAll.Visible = false;
            btnExportInTxt.Visible = false;
            lblInfoSaved.Visible = false;
            lblInfoSavedTip.Visible = false;
            btnSort.Visible = false;
            _sorted = false;
            btnSort.Enabled = true;
            lblSettingsMadeBy.Visible = false;
            lblSettingsTitle.Visible = false;
            lblSettingsCredits.Visible = false;
            lblNameAyub.Visible = false;
            lblNameEmil.Visible = false;
            lblEmil.Visible = false;
            lblAyub.Visible = false;
        }

        #region Know Your Victim screen
        
        private void btnKnowVictim_Click(object sender, EventArgs e)
        {
            SecondScreen(Properties.Resources.FindYourVictim);
            lblNameInput.Visible = true;
            textBoxNameInput.Visible = true;
            textBoxNameInput.Text = string.Empty;
            btnNameInput.Visible = true;

        }

        private void btnNameInput_Click(object sender, EventArgs e)
        {
            btnNameInput.Visible = false;
            var name = textBoxNameInput.Text.Trim();
            if (name.IsNullOrEmpty())
            {
                btnKnowVictim_Click(sender, e);
            }
            else
            {
                User victim = ReturnVictim();
                if(victim.Name == name) 
                {
                    btnNameInput_Click(sender, e);
                }
                textBoxNameInput.Visible = false;
                lblNameInput.Visible = false;

                lblVictimTitle.Visible = true;
                lblVictimName.Text = victim.Name;
                lblVictimName.Visible = true;
            }
        }

        private User ReturnVictim()
        {
            Random rand = new();
            var victim = _users[rand.Next(0, _users.Count)];
            return victim;
        }

        private void btnKnowVictim_MouseMove(object sender, MouseEventArgs e)
        {
            btnKnowVictim.BackgroundImage = Resources.victimsatan;
        }

        private void btnKnowVictim_MouseLeave(object sender, EventArgs e)
        {
            btnKnowVictim.BackgroundImage = null;
        }

        #endregion

        #region Find All screen
        
        private void btnFindAll_Click(object sender, EventArgs e)
        {
            SecondScreen(Resources.FindAllPic);

            btnGenerateList.Visible = true;
        }

        private void btnGenerateList_Click(object sender, EventArgs e)
        {
            ShuffleUsers();

            btnGenerateList.Visible = false;

            btnExportInTxt.Visible = true;
            btnRefreshFindAll.Visible = true;
            
            listBoxFindAll.Visible = true;
        }

        private void btnRefreshFindAll_Click(object sender, EventArgs e)
        {
            ShuffleUsers();
        }

        private void ShuffleUsers()
        {
            Thread shuffle = new Thread(Shuffle);

            shuffle.Start();

            Thread.Sleep(50);

            listBoxFindAll.DataSource = _lines;

        }

        private void Shuffle()
        {
            _lines = ShuffleUsersList();
        }

        private List<string> ShuffleUsersList()
        {
            var rand = new Random();

            List<User> victims = new(_users);

            List<string> lines = new List<string>();

            for (int i = 0; i < _users.Count; i++)
            {
                string line = $"SANTA {_users[i].Name}  -  ";
                var index = rand.Next(0, victims.Count);

                while (_users[i].Name == victims[index].Name)
                {
                    index = rand.Next(0, victims.Count);
                }

                line = $"{line}VICTIM {victims[index]}";

                victims.RemoveAt(index);

                lines.Add(line);
            }
            return lines;
        }

        private void btnExportInTxt_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Couples.txt";
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine("-------------------------");
                foreach (string line in _lines)
                {
                    sw.WriteLine(line);
                }
                sw.WriteLine("-------------------------");
                sw.WriteLine("                                    .!,            .!,\r\n" +
                    "                                   ~ 6 ~          ~ 6 ~\r\n" +
                    "                              .    ' i `  .-^-.   ' i `\r\n" +
                    "                            _.|,_   | |  / .-. \\   | |\r\n" +
                    "                             '|`   .|_|.| (-` ) | .|_|.\r\n" +
                    "                             / \\ ___)_(_|__`-'__|__)_(______\r\n" +
                    "                            /`,o\\)_______________________o_(\r\n" +
                    "                           /_* ~_\\[___]___[___]___[___[_[\\`-.\r\n" +
                    "                           / o .'\\[_]___[___]___[___]_[___)`-)\r\n" +
                    "                          /_,~' *_\\_]                 [_[(  (\r\n" +
                    "                          /`. *  *\\_]                 [___\\ _\\\r\n" +
                    "                         /   `~. o \\]      ;( ( ;     [_[_]`-'\r\n" +
                    "                        /_ *    `~,_\\    (( )( ;(;    [___]\r\n" +
                    "                        /   o  *  ~'\\   /\\ /\\ /\\ /\\   [_[_]\r\n" +
                    "                       / *    .~~'  o\\  ||_||_||_||   [___]\r\n" +
                    "                      /_,.~~'`    *  _\\_||_||_||_||___[_[_]_\r\n" +
                    "                      /`~..  o        \\:::::::::::::::::::::\\\r\n" +
                    "                     / *   `'~..   *   \\:::::::::::::::::::::\\\r\n" +
                    "                    /_     o    ``~~.,,_\\=========\\_/========='\r\n" +
                    "                    /  *      *     ..~'\\         _|_ .-_--.\r\n" +
                    "                   /*    o   _..~~`'*   o\\           ( (_)  )\r\n" +
                    "                   `-.__.~'`'   *   ___.-'            `----'\r\n" +
                    "                         \":-------:\"\r\n                           \\_____/");
            }
            lblInfoSaved.Visible = true;
            lblInfoSavedTip.Visible = true;

        }

        private void btnFindAll_MouseMove(object sender, MouseEventArgs e)
        {
            btnFindAll.BackgroundImage = Resources.canadsorgy;
        }

        private void btnFindAll_MouseLeave(object sender, EventArgs e)
        {
            btnFindAll.BackgroundImage = null;
        }

        #endregion

        #region Show All Players screen
        
        private void btnShowAllPlayers_Click(object sender, EventArgs e)
        {
            btnSort.Enabled = true;

            UpdateEntityList();

            SecondScreen(Properties.Resources.ShowAllPlayers);

            btnDeleteEntity.Visible = true;
            btnRenameEntity.Visible = true;
            btnAddEntity.Visible = true;
            btnSort.Visible = true;

            lblSelectedName.Visible = true;
            listBoxUsers.Visible = true;

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            _sorted = true;
            UpdateEntityList();
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _crntEntity = (User)listBoxUsers.SelectedItem;
            lblSelectedName.Text = _crntEntity.Name;

        }

        private void btnDeleteEntity_Click(object sender, EventArgs e)
        {
            if(_users.Count > 0)
            {
                _userHelper.DeleteById(_crntEntity.UserId);

                UpdateEntityList();
            }
        }


        private void btnRenameEntity_Click(Object sender, EventArgs e)
        {
            if(_users.Count > 0)
            {
                btnSort.Enabled = false;
                lblRenameTipNote.Visible = true;
                lblSelectedName.Visible = false;
                btnDeleteEntity.Visible = false;
                btnRenameEntity.Visible = false;
                btnAddEntity.Visible = false;
                listBoxUsers.Enabled = false;

                textBoxRenameUser.Text = _crntEntity.Name;
                textBoxRenameUser.Focus();
                textBoxRenameUser.Visible = true;
                btnSaveRename.Visible = true;
            }
        }

        private void btnSaveRename_Click(object sender, EventArgs e)
        {
            textBoxRenameUser.Text = textBoxRenameUser.Text.Trim();
            if (textBoxRenameUser.Text.IsNullOrEmpty())
            {
                lblExistingName.Visible = false;
                lblEmptyName.Visible = true;
                btnRenameEntity_Click(sender, e);
            }
            else if (UserNames.Contains(textBoxRenameUser.Text, StringComparer.OrdinalIgnoreCase))
            {
                lblEmptyName.Visible = false;
                lblExistingName.Visible = true;
                btnRenameEntity_Click(sender, e);
            }
            else
            {
                lblEmptyName.Visible = false;
                lblExistingName.Visible = false;

                var entity = _userHelper.ReadById(_crntEntity.UserId);
                entity.Name = textBoxRenameUser.Text;
                _userHelper.Update(entity);

                btnSaveRename.Visible = false;
                lblRenameTipNote.Visible = false;
                textBoxRenameUser.Visible = false;
                listBoxUsers.Enabled = true;

                UpdateEntityList();

                btnShowAllPlayers_Click(sender, e);
            }
        }

        public void UpdateEntityList()
        {
            _users = _userHelper.ReadAll();
            if (_sorted)
            {
                _users = _users.OrderBy(o => o.Name).ToList();
            }
            listBoxUsers.DataSource = _users;
            listBoxUsers.Refresh();
        }

        private void btnAddEntity_Click(object sender, EventArgs e)
        {
            btnSort.Enabled = false;
            lblRenameTipNote.Visible = true;
            lblSelectedName.Visible = false;
            btnDeleteEntity.Visible = false;
            btnRenameEntity.Visible = false;
            btnAddEntity.Visible = false;
            listBoxUsers.Enabled = false;

            textBoxRenameUser.Text = "";
            textBoxRenameUser.Visible = true;
            btnCreateEntity.Visible = true;
        }

        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
            textBoxRenameUser.Text = textBoxRenameUser.Text.Trim();
            if (textBoxRenameUser.Text.IsNullOrEmpty())
            {
                lblExistingName.Visible = false;
                lblEmptyName.Visible = true;
                btnAddEntity_Click(sender, e);
            }
            else if (UserNames.Contains(textBoxRenameUser.Text, StringComparer.OrdinalIgnoreCase))
            {
                lblEmptyName.Visible = false;
                lblExistingName.Visible = true;
                btnAddEntity_Click(sender, e);
            }
            else
            {
                lblEmptyName.Visible = false;
                lblExistingName.Visible = false;

                _userHelper.Create(new User(textBoxRenameUser.Text));

                btnCreateEntity.Visible = false;
                lblRenameTipNote.Visible = false;
                textBoxRenameUser.Visible = false;
                listBoxUsers.Enabled = true;
                UpdateEntityList();

                btnShowAllPlayers_Click(sender, e);
            }

        }

        private void btnShowAllPlayers_MouseMove(object sender, MouseEventArgs e)
        {
            btnShowAllPlayers.BackgroundImage = Resources.showall;
        }

        private void btnShowAllPlayers_MouseLeave(object sender, EventArgs e)
        {
            btnShowAllPlayers.BackgroundImage = null;
        }

        #endregion

        #region Credits screen
        
        private void btnCredits_Click(object sender, EventArgs e)
        {
            SecondScreen(Resources.SettingsPic);

            lblSettingsMadeBy.Visible = true;
            lblSettingsTitle.Visible = true;
            lblSettingsCredits.Visible = true;
            lblNameAyub.Visible = true;
            lblNameEmil.Visible = true;
            lblEmil.Visible = true;
            lblAyub.Visible = true;
        }

        private void btnCredits_MouseMove(object sender, MouseEventArgs e)
        {
            btnCredits.BackgroundImage = Resources.credits;
        }

        private void btnCredits_MouseLeave(object sender, EventArgs e)
        {
            btnCredits.BackgroundImage = null;
        }

        #endregion

        private void SecondScreen(Image image)
        {
            backgroundPicture.Image = image;

            lblTitle.Visible = false;
            btnKnowVictim.Visible = false;
            btnFindAll.Visible = false;
            btnShowAllPlayers.Visible = false;
            btnCredits.Visible = false;
            btnBack.Visible = true;
        }

    }
}