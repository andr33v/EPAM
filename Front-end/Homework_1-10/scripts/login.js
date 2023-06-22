//Login
let button = document.getElementById("header__nav-item-second-button");
let isBuy = false;
let isLogin;
let buttonOut = document.getElementById("header__nav-item-second-button-out");
const current = JSON.parse(localStorage.getItem("currentUser"));
if(current !== null){
    const cartButton = document.querySelector(".cart-button");
    cartButton.style.display = "flex";
    button.style.display = "none";
    buttonOut.style.display = "flex";
    if(current.login !== "" && current.login != null){
        isBuy = true;
    }
}
else{
button.addEventListener("click", function() {
    function promptLogin() {
        return prompt("Enter your login: ");
    }

    function promptPassword(){
        return prompt("Enter your password: ");
    }

    function checkLogin(log, login) {
        return log === login ? "admin" : log === "" || log == null ? "guest" : "user";
    }

    function checkPassword(inputPassword, password) {
        return inputPassword === password;
    }

    const login = "admin";
    const password = "12345";
    let isAdmin;

    const users = JSON.parse(localStorage.getItem("allUsers")) || [];
    
    while(true){
        const user = {};

        let log = promptLogin();

        if(checkLogin(log, login) === "admin") {
            let inputPassword = promptPassword();
            if(checkPassword(inputPassword, password)) {
                isAdmin = true;
                isLogin = true;
                user.login = log;
                user.password = password;
                user.isAdmin = isAdmin;
                alert(`Welcome, ${user.login}!`);
                saveData(user, users, isLogin);
                button.style.display = "none";
                break;
            }
            else{
                user.login = log;
                user.password = inputPassword;
                saveData(user, users, isLogin);
                alert("Wrong password!");
            }
        }
        else if(checkLogin(log, login) === "user"){     
            let userPassword = promptPassword();
            const checkUser = users.find((user) => user.login === log);
            if(checkUser && checkUser.password !== userPassword){
                user.login = log;
                user.password = userPassword;
                saveData(user, users, isLogin);
                alert(`Wrong password, try again!`);
            }
            else{     
                isAdmin = false;
                isLogin = true;
                user.login = log;
                user.password = userPassword;
                user.isAdmin = isAdmin;
                alert(`Welcome, ${user.login}!`);
                saveData(user, users, isLogin);
                button.style.display = "none";
                break;
            }
        }
        else{
            const checkGuest = users.find((user) => user.login === log);

            alert("Welcome, guest!");
            isAdmin = false;
            isLogin = true;
            user.login = log;
            user.password = "";
            user.isAdmin = isAdmin;
            if(!checkGuest){
                saveData(user, users, isLogin);
                button.style.display = "none";
                break;
            }

            const attempts = JSON.parse(localStorage.getItem("attempts")) || [];
            const cartButton = document.querySelector(".cart-button");
            cartButton.style.display = "flex";
            saveUserToLocalStorage(user);

            const tempUser = {};
            tempUser.login = user.login;
            tempUser.password = user.password;

            attempts.push(tempUser);
            addUserAttemptToLocalStorage(attempts);

            button.style.display = "none";
            location.reload();
            break;
        }
    }
});
}
//Save to local storage
function saveUserToLocalStorage(user){
    localStorage.setItem("currentUser", JSON.stringify(user));
}

function addUserToLocalStorage(user){
    localStorage.setItem("allUsers", JSON.stringify(user));
}

function addUserAttemptToLocalStorage(attempt){
    localStorage.setItem("attempts", JSON.stringify(attempt));
}

function saveData(user, users, isLogin){
    const attempts = JSON.parse(localStorage.getItem("attempts")) || [];
    if(isLogin){
        const cartButton = document.querySelector(".cart-button");
        cartButton.style.display = "flex";
        saveUserToLocalStorage(user);

        const tempUser = {};
        tempUser.login = user.login;
        tempUser.password = user.password;

        attempts.push(tempUser);
        addUserAttemptToLocalStorage(attempts);
        
        users.push(tempUser);
        addUserToLocalStorage(users);
        location.reload();
    }
    else{
        const tempUser = {};
        tempUser.login = user.login;
        tempUser.password = user.password;
        
        attempts.push(tempUser);
        addUserAttemptToLocalStorage(attempts);

        user.login = null;
        user.password = null;
    }
}

//Log Out
buttonOut.addEventListener("click", function() {
    const user = JSON.parse(localStorage.getItem("currentUser"));
    if(user !== null){
        alert(`Goodbye, ${user.login !== "" && user.login != null ? user.login : "guest"}!`);
        localStorage.removeItem("currentUser");
    }
    location.reload();
});