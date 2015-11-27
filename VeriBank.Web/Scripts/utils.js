﻿function BindCurrencyFormatter() {
    $('input[type=number]').bind('keydown', function () {

        //number-format the user input
        this.value = parseFloat(this.value.replace(/,/g, ""))
                        .toFixed(2)
                        .toString()
                        .replace(/\B(?=(\d{3})+(?!\d))/g, ",");

        //set the numeric value to a number input
        //document.getElementById("number").value = this.value.replace(/,/g, "")

    });
}