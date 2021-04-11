function showModalToConfirmDelete(profileTypeId) {

    $("#btnConfirmDelete").attr("entityId", profileTypeId);
    $("#modalConfirmDelete").modal("show");
}

function deleteProfileType(element) {
    const profileTypeId = $(element).attr("entityId");

    if (profileTypeId === null || profileTypeId === "") {
        alert("Identificador não encontrado para enviar.");
        return;
    }

    $("#modalConfirmDelete").modal("hide");
    const url = `${URL_DELETE_PROFILE_TYPE}?profileTypeId=${profileTypeId}`;

    AjaxPostGenerics(null, url, profileTypeId, 'DELETE');
}