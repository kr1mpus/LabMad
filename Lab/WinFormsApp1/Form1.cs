using ClassLibrary1;

namespace WinFormsApp1
{
    public partial class Form1 : Form, IUserInfo
    {
        private UserInfoPresenter _presenter;
        public Form1()
        {
            InitializeComponent();
            this._presenter = new UserInfoPresenter(this);

            comboBoxGender.Items.Add(Gender.Мужчина);
            comboBoxGender.Items.Add(Gender.Женщина);

        }

        private void Save_Click(object sender, EventArgs e)
        {

            SaveAttempted?.Invoke(this, EventArgs.Empty);
        }

        string IUserInfo.FirstName { get => this.FirstName.Text; set => this.FirstName.Text = value; }
        string IUserInfo.LastName { get => this.LastName.Text; set => this.LastName.Text = value; }
        string IUserInfo.Email { get => this.Email.Text; set => this.Email.Text = value; }
        string IUserInfo.PhoneNumber { get => this.Phone.Text; set => this.Phone.Text = value; }
        string IUserInfo.ErrorMessage { get => this.ErrorMessage.Text; set => this.ErrorMessage.Text = value; }
        bool IUserInfo.ShowFormErrors { get => this.ErrorMessage.Visible; set => this.ErrorMessage.Visible = value; }
        string IUserInfo.PlaceOfResidence { get => this.textBoxPlaceOfResidence.Text; set => this.textBoxPlaceOfResidence.Text = value; }
        public Gender Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public event EventHandler? SaveAttempted;

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}