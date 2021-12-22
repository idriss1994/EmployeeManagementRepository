function confirmDelete(uniqueId, isDeleteClicked) {

    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;
    console.log(deleteSpan, confirmDeleteSpan);
    if (isDeleteClicked) {

        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    } else {

        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
} 