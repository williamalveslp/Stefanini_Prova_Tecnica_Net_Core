$('#btnSave').click(function () {
    save();
});

function save() {

    var taskId = $('#hddTaskId').val();
    var name = $('#txtName').val();

    if (name === null || name === "") {
        alert('Campos "Nome" não informado.');
        return;
    }

    var data = {
        'Id': taskId,
        'Name': name
    };

    AjaxPostGenerics(data, URL_SAVE_TASK, $('#hddTaskId'), 'POST');
}

$('#btnClear').click(function () {
    $('#txtName').val('');
});