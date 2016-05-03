var uri = 'tasks/';
var companyUri = 'company/';
var patientUri = 'patient/';
var companyName = "";
var patientName = "";
var patient;
var company;
$(document).ready(function () {
    // Send an AJAX request
    $.getJSON(uri + "getall")
        .done(function (data) {
            // On success, 'data' contains a list of products.
            $.each(data, function (key, item) {
                // Add a list item for the product.
                $('<li>', { text: formatItem(item) }).appendTo($('#tasks'));
            });
        });
});

function formatItem(item) {
    item.TaskDate = item.TaskDate.substring(0, item.TaskDate.toLocaleString().indexOf(':') - 3);
    return item.TaskID + " " + item.company.Name + " " + item.patient.FirstName + " " + item.patient.LastName + " " + item.TaskName + " " + item.TaskDate;
}

function find() {
    var id = $('#taskId').val();
    var index = 0;
    $.getJSON('tasks/' + id)
        .done(function (data) {    
            // $('#task').text(formatItem(data));
            $.each(data, function (key, item) {
                // Add a list item for the product.
                $('#task').text(formatItem(data[index]));
                index++;
            });
        })
        .fail(function (jqXHR, textStatus, err) {
            $('#task').text('Error: ' + err);
        });
}