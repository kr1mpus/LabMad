namespace ClassLibrary1;

public class UserInfoPresenter
{
    private readonly IUserInfo _form;

    public UserInfoPresenter(IUserInfo form)
    {
        _form = form;
        _form.SaveAttempted += _form_SaveAttempted;
    }

    private void _form_SaveAttempted(object? sender, EventArgs e)
    {
        _form.ShowFormErrors = false;
        _form.ErrorMessage = null;
        if (string.IsNullOrEmpty(_form.FirstName))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nПоле `Имя` не может быть пустым";
        }
        if (string.IsNullOrEmpty(_form.LastName))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nПоле `Фамилия` не может быть пустым";
        }
        if (string.IsNullOrEmpty(_form.Email))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nПоле `Почта` не может быть пустым";
        }
        if (string.IsNullOrEmpty(_form.PhoneNumber))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nПоле `Номер телефона` не может быть пустым";
        }

        if (!string.IsNullOrEmpty(_form.Email) && !_form.Email.Contains("@"))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nПоле `Почта` должно содержать символ `@`";
        }
        if(!string.IsNullOrEmpty(_form.LastName) && !char.IsUpper(_form.LastName[0]))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nФамилия должна начинаться с заглавной буквы";
        }
        if (!string.IsNullOrEmpty(_form.PhoneNumber) && !(_form.PhoneNumber[0] == '8' || (_form.PhoneNumber[0] == '+' && _form.PhoneNumber[1] == '7')))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nТелефон должен начинаться с `+7` или `8`";
        }

        if (!_form.PlaceOfResidence.Contains("Россия"))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nМесто жительства должно содержать `Россия`";
        }

            

    }
}