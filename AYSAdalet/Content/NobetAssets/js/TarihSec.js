$(document).ready(function () {
    let now = new Date();

    let day = ("0" + now.getDate()).slice(-2);
    let month = ("0" + (now.getMonth() + 1)).slice(-2);

    let today = (day) + "-" + (month) + "-" + now.getFullYear();


    $('#datePicker').val(today);

    $('#datebtn').click(function () {

        testClicked();

    });
});
function testClicked() {
    $('.getDate').html($('#datePicker').val());
}