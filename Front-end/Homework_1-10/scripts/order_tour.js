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

//Display chosen tour
const tourLinks = document.querySelectorAll("#nav-link");
tourLinks.forEach((link) => {
  link.addEventListener("click", (event) => {
    const tourCards = document.querySelectorAll(".tour-card");
    tourCards.forEach((card) => {
      card.classList.remove("active-card");
    });

    const tourCardId = event.target.getAttribute("href").substring(1);
    const tourCard = document.getElementById(tourCardId);

    if (tourCard) {
      tourCard.classList.add("active-card");
    }
  });
});