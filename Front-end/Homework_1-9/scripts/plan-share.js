//Plan button
const plan = document.getElementById("tripPlan");
const planButton = document.getElementById("button__plan");
const closePlan = document.querySelector(".plan-close");
const submitButton = document.getElementById("submit-button");
const page = document.querySelector(".main");

planButton.addEventListener("click", function(){
    plan.style.display = "block";
    page.classList.add("blur-background");
});

closePlan.addEventListener("click", function(){
    plan.style.display = "none";
    page.classList.remove("blur-background");
});

window.addEventListener("click", (event) => {
    if (event.target === plan){
        plan.style.display = "none";
        page.classList.remove("blur-background");
    }
});

submitButton.addEventListener("click", function(){
    const mail = document.getElementById("email").value;
    const desc = document.getElementById("description").value;

    if(mail.indexOf("@") === -1)
    {
        alert("Please enter your email!");
        return;
    }

    let domain = mail.split("@");
    if (domain.length !== 2 || domain[0] === "" || domain[1] === "" || domain[1].split(".").length !== 2) {
        alert("Please enter a valid email!");
        return;
    }

    if(desc === "")
    {
        alert("Please enter a description!");
        return;
    }

    alert("Thanks for submitting!");
    plan.style.display = "none";
    page.classList.remove("blur-background");
});

//Share button
const share = document.getElementById("button__share");
share.addEventListener("click", function(){
    window.open("https://www.instagram.com/explore/tags/travels/");
});
