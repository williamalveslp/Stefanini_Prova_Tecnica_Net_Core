function showModalToConfirmDelete(profileTypeId) {

    $("#btnConfirmDelete").attr("entityId", profileTypeId);
    $("#modalConfirmDelete").modal("show");
}

function deleteProfileType(element) {

    var profileTypeId = $(element).attr("entityId");

    if (profileTypeId === null || profileTypeId === "") {
        alert("Identificador não encontrado para enviar.");
        return;
    }
    var data = {
        "profileTypeId": profileTypeId
    };

    $("#modalConfirmDelete").modal("hide");
    AjaxPostGenerics(data, URL_DELETE_PROFILE_TYPE, null, 'DELETE');
}