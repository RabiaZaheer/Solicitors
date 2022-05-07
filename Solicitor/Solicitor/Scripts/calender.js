$(document).ready(function () {

    $.validator.addMethod('date',
        function (value, element) {
            if (this.optional(element)) {
                return true;
            }
            var valid = true;
            try {
                $.datepicker.parseDate('dd/mm/yy', value);
            }
            catch (err) {
                valid = false;
            }
            return valid;
        });

    $(".calender").datepicker({
        dateFormat: "dd/mm/yy"
    });
});