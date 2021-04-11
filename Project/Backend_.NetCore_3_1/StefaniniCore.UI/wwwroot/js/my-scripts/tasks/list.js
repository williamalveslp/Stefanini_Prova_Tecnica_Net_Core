function showModalToConfirmDelete(taskId) {

    $("#btnConfirmDelete").attr("entityId", taskId);
    $("#modalConfirmDelete").modal("show");
}

function deleteTask(element) {
    const taskId = $(element).attr("entityId");

    if (taskId === null || taskId === "") {
        alert("Identificador não encontrado para enviar.");
        return;
    }

    $("#modalConfirmDelete").modal("hide");
    const url = `${URL_DELETE_TASK}?taskId=${taskId}`;

    AjaxPostGenerics(null, url, taskId, 'DELETE');
}