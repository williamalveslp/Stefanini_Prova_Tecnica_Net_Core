$('#btnSave').click(function () {
    save();
});

function save() {

    const taskId = $('#hddTaskId').val();
    const name = $('#txtName').val();
    const description = $('#txtDescription').val();

    if (name === null || name === "") {
        alert('Campos "Nome" não informado.');
        return;
    }

    const data = {
        'Id': taskId,
        'Name': name,
        'Description': description

    };

    AjaxPostGenerics(data, URL_SAVE_TASK, $('#hddTaskId'), 'POST');
}

$('#btnClear').click(function () {
    $('#txtName').val('');
});