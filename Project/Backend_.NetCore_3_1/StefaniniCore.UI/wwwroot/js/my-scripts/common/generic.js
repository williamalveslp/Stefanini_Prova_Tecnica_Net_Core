function AjaxPostGenerics(data, url, idElementToUpdate, method = 'POST') {

    $.ajax({
        type: method,
        url: url,
        cache: false,
        async: true,
        data: data ? data : {},
        beforeSend: function () {
            // start loading
        },
        complete: function () {
            // close loading
        },
        success: function (data) {
            successMessage(idElementToUpdate, data);
        },
        error: function (data) {
            errorMessage(data);
        }
    });
}

function successMessage(idElementToUpdate, data) {

    if (idElementToUpdate && data.id)
        idElementToUpdate.val(data.id);

    if (data.urlToRedirect) {
        window.location = data.urlToRedirect;
        return;
    }

    if (!data.statusCode || !data.message) {
        console.error('Invalid response data.');
        return;
    }

    console.info('[' + data.statusCode + '] ' + data.message);
    
    if (!data.refreshPage) {
        alert(data.message);
        return;
    }

    // Wait 1 second and refresh the page.
    setTimeout(() => {
        alert(data.message);
        window.location.reload(false);
    }, 1000);
}

function errorMessage(data) {

    if (data && data.responseJSON.message) {

        if (data.responseJSON.urlToRedirect)
            window.location = data.responseJSON.urlToRedirect;
        else {
            console.error('[' + data.status + '] ' + data.responseJSON.message);
            alert(data.responseJSON.message);
        }

    } else {
        const message = 'Erro ocorreu no envio da requisição. Tente mais tarde.';
        console.error('[' + data.status + '] ' + message);

        alert(message);
    }
}