$('#btnSignIn').click(function () {
    save();
});

function save() {

    var userName = $('#txtUserName').val();
    var password = $('#txtPassword').val();

    if (userName === null || userName === '') {
        alert('Campos "Nome do Usuário" não informado.');
        return;
    }

    if (password === null || password === '') {
        alert('Campos "Senha" não informado.');
        return;
    }

    var data = {
        'UserName': userName,
        'Password': password,
    };

    AjaxPostGenerics(data, URL_SIGNIN_USER_SYSTEM, null, 'POST');
}