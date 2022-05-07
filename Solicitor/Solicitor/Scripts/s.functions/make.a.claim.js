var isError = false;
function OnBeginMethod() {
	$(".message").html("");
}

function OnFailtureMethod(error) {
	$(".message").html('<div class="validation validation-error row">An error has occured, please try again.</div>');
	isError = true;
}

function OnSuccessMethod(data) {
	$(".message").html('<div class="validation validation-success row">Thankyou, soon one of our team member will contact you.</div>');
	$("#Name").val('');
	$("#Email").val('');
	$("#ContactNo").val('');
	$("#Detail").val('');
}

function OnCompleteMethod(data, status) {
	if (!isError) {
		$(".message").html('<div class="validation validation-success row">Thankyou, soon one of our team member will contact you.</div>');
	}
}