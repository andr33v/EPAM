//Buy button
document.addEventListener("DOMContentLoaded", function(){
    const buyButton = document.querySelectorAll(".tour-card__button-buy");
    buyButton.forEach((button, index) => {
        button.addEventListener("click", () =>{
            if(isBuy){
                const tours = moreInfoTours[index];
                alert("Successful purchase!\nYou bought " 
                + tours.name + " tour!" + "\nDuration: " + tours.duration 
                + " Days\n" + "Price: " + tours.price + " $");
            }
            else{
                alert("Log in to your account to make purchases!");
            }
        });
    });
});