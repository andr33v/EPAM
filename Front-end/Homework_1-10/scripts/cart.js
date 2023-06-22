function getCartFromLocalStorage(user) {
  const cart = localStorage.getItem(user.login + "Cart");
  return cart ? JSON.parse(cart) : [];
}

function saveCartToLocalStorage(cart, user) {
  localStorage.setItem(user.login + "Cart", JSON.stringify(cart));
}

function updateCartButton(user) {
  const cartButton = document.querySelector(".cart-button");
  const cart = getCartFromLocalStorage(user);
  const totalCount = cart.reduce((count, tour) => count + tour.count, 0);

  cartButton.textContent = totalCount > 0 ? `Cart (${totalCount})` : `Cart`;
}

function updateCartModal(user) {
  const cart = getCartFromLocalStorage(user);
  const cartItemsContainer = document.querySelector(".cart-items");
  cartItemsContainer.innerHTML = "";

  cart.forEach((tour, index) => {
    const cartItem = document.createElement("div");
    cartItem.classList.add("cart-item");
    const title = document.createElement("span");
    title.classList.add("cart-item__title");
    title.textContent = `${tour.name} (${tour.count})`;

    const price = document.createElement("span");
    price.classList.add("cart-item__price");
    const totalPrice = tour.price * tour.count;
    price.textContent = `${totalPrice} $`;

    const removeButton = document.createElement("button");
    removeButton.classList.add("cart-item__remove");
    removeButton.textContent = "Remove";
    removeButton.addEventListener("click", () => {
      if (tour.count > 1) {
        tour.count -= 1;
      } else {
        cart.splice(index, 1);
      }
      saveCartToLocalStorage(cart, user);
      updateCartButton(user);
      updateCartModal(user);
    });
    cartItem.appendChild(title);
    cartItem.appendChild(price);
    cartItem.appendChild(removeButton);

    cartItemsContainer.appendChild(cartItem);
  });

  const total = cart.reduce((sum, tour) => sum + tour.price * tour.count, 0);
  const totalElement = document.querySelector(".cart-total__value");
  totalElement.textContent = `$${total}`;
}

function showCartModal(user) {
  const cartModal = document.querySelector(".cart-modal");
  cartModal.style.display = "flex";
  page.classList.add("blur-background");
  updateCartModal(user);
}

function hideCartModal(user) {
  const cartModal = document.querySelector(".cart-modal");
  cartModal.style.display = "none";
  page.classList.remove("blur-background");
  updateCartModal(user);
}

function addEventListeners(user) {
  const buyButtons = document.querySelectorAll(".tour-card__button-buy");
  buyButtons.forEach((button, index) => {
    button.addEventListener("click", () => {
      if (isBuy) {
        const cart = getCartFromLocalStorage(user);
        const existingTourIndex = cart.findIndex((tour) => tour.id === toursCardsData[index].id);
        if (existingTourIndex !== -1) {
          cart[existingTourIndex].count += 1;
        } else {
          const newTour = { ...toursCardsData[index], count: 1 };
          cart.push(newTour);
        }
        saveCartToLocalStorage(cart, user);
        updateCartButton(user);
      }
    });
  });

  const cartButton = document.querySelector(".cart-button");
  cartButton.addEventListener("click", () => showCartModal(user));
  const closeModalButton = document.querySelector(".cart-modal__close");
  closeModalButton.addEventListener("click", () => hideCartModal(user));

  window.addEventListener("click", (event) => {
    if (event.target === cartModal){
        cartModal.style.display = "none";
        page.classList.remove("blur-background");
    }
  });
}

const currentUser = JSON.parse(localStorage.getItem("currentUser"));
if (currentUser !== null) {
  updateCartButton(currentUser);
  addEventListeners(currentUser);
}