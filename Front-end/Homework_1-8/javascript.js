//Login
let button = document.getElementById("header__nav-item-second-button");
button.addEventListener("click", function() {
    function promptLogin() {
        return prompt("Enter your login: ");
    }

    function promptPassword(){
        return prompt("Enter your password: ");
    }

    function checkLogin(log, login) {
        return log === login;
    }

    function checkPassword(inputPassword, password) {
        return inputPassword === password;
    }

    const login = "admin";
    const password = "12345";
    let isAdmin;

    const user = {};
    
    while(true){
        let log = promptLogin();

        if(checkLogin(log, login)) {
            let inputPassword = promptPassword();
            if(checkPassword(inputPassword, password)) {
                isAdmin = true;
                user.login = true;
                user.password = password;
                user.isAdmin = isAdmin;
                alert("Welcome!");
                break;
            }
            else{
                alert("Wrong password!");
            }
        }
        else if(log === null || log === "") {
            isAdmin = false;
            user.login = log;
            user.isAdmin = isAdmin;
            alert("Welcome!");
            break;
        }
        else{
            alert("Access denied!");
            break;
        }
    }
});

//Objects and functions
const tour = {
    name: "Mystical Bali Adventure",
    description: `Explore the enchanting island of Bali, with its lush jungles, vibrant culture, and ancient temples.
    Visit the iconic Tanah Lot temple, hike to the summit of Mount Batur, and unwind on the pristine
    beaches of Nusa Dua.`,
    price: 2000,
    duration: 7,
    displayInfo: function(){
        console.log("Name: " + this.name + "\n" + "Description: " + this.description + "\n" + "Price: " + this.price + "$\n" + "Duration: " + this.duration + "d");
    }
}

function calculateTotalCost(tour, travelers){
    totalCost = tour.price * travelers
    console.log("Total cost: " + totalCost + "$");
}

tour.displayInfo()
calculateTotalCost(tour, 15);

//Strings and arrays
