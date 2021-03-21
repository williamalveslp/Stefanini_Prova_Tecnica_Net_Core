function showModalToConfirmDelete(taskId) {

    $("#btnConfirmDelete").attr("entityId", taskId);
    $("#modalConfirmDelete").modal("show");
}

function deleteTask(element) {

    var taskId = $(element).attr("entityId");

    if (taskId === null || taskId === "") {
        alert("Identificador não encontrado para enviar.");
        return;
    }
    var data = {
        "taskId": taskId
    };

    $("#modalConfirmDelete").modal("hide");
    AjaxPostGenerics(data, URL_DELETE_TASK, null, 'DELETE');
}