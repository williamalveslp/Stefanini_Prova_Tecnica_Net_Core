$('#btnSave').click(function () {
    save();
});

function save() {

    var taskId = $('#hddTaskId').val();
    var name = $('#txtName').val();
    var description = $('#txtDescription').val();

    if (name === null || name === "") {
        alert('Campos "Nome" não informado.');
        return;
    }

    var data = {
        'Id': taskId,
        'Name': name,
        'Description': description
    };

    AjaxPostGenerics(data, URL_SAVE_TASK, $('#hddTaskId'), 'POST');
}

$('#btnClear').click(function () {
    $('#txtName').val('');
    $('#txtDescription').val('');
});