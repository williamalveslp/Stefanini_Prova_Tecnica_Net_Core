$('#btnSave').click(function () {
    save();
});

function save() {

    const profileTypeId = $('#hddProfileTypeId').val();
    const name = $('#txtName').val();

    if (!TASKS_ARRAY || TASKS_ARRAY.length <= 0) {
        alert('Não foi selecionado "Funcionalidades" para o Perfil.');
        return;
    }

    if (name === null || name === "") {
        alert('Campo "Nome" não informado.');
        return;
    }

    let taskIds = [];

    for (var i = 0; i < TASKS_ARRAY.length; i++) {
        taskIds.push(TASKS_ARRAY[i].id);
    }

    var data = {
        'id': profileTypeId,
        'name': name,
        'taskIds': taskIds
    };

    AjaxPostGenerics(data, URL_SAVE_PROFILE_TYPE, $('#hddProfileTypeId'), 'POST');
}

$('#btnClear').click(function () {
    $('#txtName').val('');

    if (!TASKS_ARRAY) {
        for (var i = TASKS_ARRAY.length - 1; i >= 0; i--) {
            var rowId = "taskRow_" + TASKS_ARRAY[i].id;

            // Remove from HTML list.
            var rowToDelete = $("#" + rowId);
            rowToDelete.remove();
        }
    }

    TASKS_ARRAY = [];
});

function addTask(id, name) {

    for (let i = TASKS_ARRAY.length - 1; i >= 0; i--) {
        if (TASKS_ARRAY[i].id === id) {
            alert('Funcionalidade já está adicionada.')
            return;
        }
    }

    TASKS_ARRAY.push(
        {
            id: id,
            name: name
        }
    );

    const rowId = "taskRow_" + id;

    const html =
        '<tr id="' + rowId + '">'
        + '<td>' + id + '</td>'
        + '<td>' + name + '</td>'
        + '</tr >';

    $("#tBodyIdNewRows").append(html);
}

function removeTask(id, name) {

    if (!TASKS_ARRAY || TASKS_ARRAY.length <= 0)
        return;

    const task = {
        id: id,
        name: name
    };

    let matchToDelete = false;

    // Remove from Array.
    for (var i = TASKS_ARRAY.length - 1; i >= 0; i--) {
        if (TASKS_ARRAY[i].id === task.id) {
            TASKS_ARRAY.splice(i, 1);
            matchToDelete = true;
        }
    }

    if (!matchToDelete) {
        alert('Funcionalidade não está adicionada para ser removida.');
        return;
    }

    const rowId = "taskRow_" + id;

    // Remove from HTML list.
    const rowToDelete = $("#" + rowId);
    rowToDelete.remove();
}