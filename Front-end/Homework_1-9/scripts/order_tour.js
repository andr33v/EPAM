//Buy button
document.addEventListener("DOMContentLoaded", function(){
    const buyButton = document.querySelectorAll(".tour-card__button-buy");
    buyButton.forEach((but, idx) => {
        but.addEventListener("click", () =>{
            const tours = moreInfoTours[idx];
            alert("Successful purchase!\nYou bought " + tours.name + " tour!" + "\nDuration: " + tours.duration + " Days\n" + "Price: " + tours.price + " $");
        });
    });
});