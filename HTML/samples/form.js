function Check()
{
    var fOk = true;
    var form = document.forms[0];

    //логин
    if (form.text_login.value.trim().length == 0) {
        fOk = false;
        alert("укажите логин");
    }
    else {
        var reg = new RegExp("[A-Z0-9]", "i");
        if (reg.test(form.text_login.value))
        {
            fOk = false;
            alert("В логине обнаружены недопустимые символы");
        }
    }

    //Проверка пароля
    if (form.text_password1.value !== form.text_password2.value)
    {
        fOk = false;
        alert("пароли не совпадают");
    }

    //ФИО
    if (form.text_fio.value.trim().length == 0)
    {
        fOk = false;
        alert("ФИО не может быть пустым");
    }

    //Email
    var reg = new RegExp("^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$", "i"); // флаги - строка из любой комбинации символов g(глобальный поиск), i(регистр неважен) и m(многострочный поиск).

    if (!reg.test(form.text_email.value)) {
        fOk = false;
        alert("Указан не верный Email");
    }

}