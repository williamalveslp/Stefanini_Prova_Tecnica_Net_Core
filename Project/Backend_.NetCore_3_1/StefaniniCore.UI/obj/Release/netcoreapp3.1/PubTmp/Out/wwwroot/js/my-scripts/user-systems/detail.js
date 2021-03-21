$('#btnSave').click(function () {
    save();
});

function save() {

    var userNameId = $('#hddUserSystemId').val();
    var userName = $('#txtUserName').val();
    var password = $('#txtPassword').val();
    var confirmPassword = $('#txtConfirmPassword').val();
    var profileTypeId = $('#ddProfileType').val();

    if (userName === null || userName === '') {
        alert('Campos "Nome do Usuário" não informado.');
        return;
    }

    if (password === null || password === '') {
        alert('Campos "Senha" não informado.');
        return;
    }

    if (confirmPassword === null || confirmPassword === '') {
        alert('Campos "Nome do Usuário" não informado.');
        return;
    }

    if (profileTypeId === null || profileTypeId <= 0) {
        alert('Campos "Perfil" não selecionado.');
        return;
    }

    if (password !== confirmPassword) {
        alert('As Senhas não coincidem.');
        return;
    }

    var data = {
        'Id': userNameId,
        'UserName': userName,
        'Password': password,
        'ProfileTypeId': profileTypeId
    };

    AjaxPostGenerics(data, URL_SAVE_USER_SYSTEM, $('#hddUserSystemId'), 'POST');
}

$('#btnClear').click(function () {
    $('#txtUserName').val('');
    $('#txtPassword').val('');
    $('#txtConfirmPassword').val('');
    $('#ddProfileType').val('');
});