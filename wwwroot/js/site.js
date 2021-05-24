// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(() => {
    $('#file').change(() => {
        let file = $('#file');
        if (file && file[0].files && file[0].files[0]) {
            let filename = file[0].files[0].name;
            $("#file-name-container").html(filename);
        }
        $("#submit-file-btn").prop("disabled", false);
    });
});
