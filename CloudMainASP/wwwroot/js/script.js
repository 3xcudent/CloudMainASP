

const rangeInput = document.querySelectorAll(".cm-find-range-input input"),
    priceInput = document.querySelectorAll(".cm-find-price-input input"),
    range = document.querySelector(".cm-find-slider .cm-find-progress");
let priceGap = 1000;
priceInput.forEach(input => {
    input.addEventListener("input", e => {
        let minPrice = parseInt(priceInput[0].value),
            maxPrice = parseInt(priceInput[1].value);

        if ((maxPrice - minPrice >= priceGap) && maxPrice <= rangeInput[1].max) {
            if (e.target.className === "input-min") {
                rangeInput[0].value = minPrice;
                range.style.left = ((minPrice / rangeInput[0].max) * 100) + "%";
            } else {
                rangeInput[1].value = maxPrice;
                range.style.right = 100 - (maxPrice / rangeInput[1].max) * 100 + "%";
            }
        }
    });
});
rangeInput.forEach(input => {
    input.addEventListener("input", e => {
        let minVal = parseInt(rangeInput[0].value),
            maxVal = parseInt(rangeInput[1].value);
        if ((maxVal - minVal) < priceGap) {
            if (e.target.className === "range-min") {
                rangeInput[0].value = maxVal - priceGap
            } else {
                rangeInput[1].value = minVal + priceGap;
            }
        } else {
            priceInput[0].value = minVal;
            priceInput[1].value = maxVal;
            range.style.left = ((minVal / rangeInput[0].max) * 100) + "%";
            range.style.right = 100 - (maxVal / rangeInput[1].max) * 100 + "%";
        }
    });
});





const rangeInputT = document.querySelectorAll(".cm-find-range-input-two input"),
    priceInputT = document.querySelectorAll(".cm-find-price-input-two input"),
    rangeT = document.querySelector(".cm-find-slider-two .cm-find-progress-two");
let priceGapT = 1000;
priceInputT.forEach(input => {
    input.addEventListener("input", e => {
        let minPrice = parseInt(priceInputT[0].value),
            maxPrice = parseInt(priceInputT[1].value);

        if ((maxPrice - minPrice >= priceGapT) && maxPrice <= rangeInputT[1].max) {
            if (e.target.className === "input-min-two") {
                rangeInputT[0].value = minPrice;
                rangeT.style.left = ((minPrice / rangeInputT[0].max) * 100) + "%";
            } else {
                rangeInputT[1].value = maxPrice;
                rangeT.style.right = 100 - (maxPrice / rangeInputT[1].max) * 100 + "%";
            }
        }
    });
});
rangeInputT.forEach(input => {
    input.addEventListener("input", e => {
        let minVal = parseInt(rangeInputT[0].value),
            maxVal = parseInt(rangeInputT[1].value);
        if ((maxVal - minVal) < priceGapT) {
            if (e.target.className === "range-min-two") {
                rangeInputT[0].value = maxVal - priceGapT
            } else {
                rangeInputT[1].value = minVal + priceGapT;
            }
        } else {
            priceInputT[0].value = minVal;
            priceInputT[1].value = maxVal;
            rangeT.style.left = ((minVal / rangeInputT[0].max) * 100) + "%";
            rangeT.style.right = 100 - (maxVal / rangeInputT[1].max) * 100 + "%";
        }
    });
});


$('.navTrigger').click(function () {
    $('.nav-menu-mobile').toggleClass('open');
});

