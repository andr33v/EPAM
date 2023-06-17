const toursCardsData = [
    {
        id: 'bali',
        name: "Mystical Bali Adventure",
        description: `Explore the enchanting island of Bali, with its lush jungles, vibrant culture, and ancient temples.
        Visit the iconic Tanah Lot temple, hike to the summit of Mount Batur, and unwind on the pristine
        beaches of Nusa Dua.`,
        price: 2000,
        duration: 7,
        image: 'images/bali.jpg',
    },

    {
        id: 'paris',
        name: "Incredibly beautiful Paris trip",
        description: `The city of love is the ultimate romantic vacation destination. Stroll hand-in-hand along 
        the Champs-Élysées, grab coffee and croissants from a local boulangerie, and take in the city sights
        from Montmartre.`,
        price: 2000,
        duration: 7,
        image: 'images/paris.jpg',
    },

    {
        id: 'egypt',
        name: "Enigmatic Egyptian Odyssey", 
        description: `Uncover the mysteries of ancient Egypt, from the iconic pyramids and Sphinx to the bustling markets
        and vibrant cities along the Nile River. Delve into the history, art, and culture that have
        captivated the world for millennia.`, 
        price: 3500,
        duration: 10,
        image: 'images/egypt.jpg',
    },

    {
        id: 'alaska',
        name: "Alaskan Wilderness Expedition", 
        description: `Immerse yourself in the rugged beauty of Alaska, 
        a land of towering mountains, pristine glaciers, and lush forests.
        Explore untouched wilderness, witness awe-inspiring wildlife, 
        and experience unforgettable adventures.`,
        price: 1800,
        duration: 8,
        image: 'images/alaska.jpg',
    },

    {
        id: 'zeland',
        name: "Scenic New Zealand Adventure", 
        description: `Traverse the stunning landscapes of New Zealand, from the lush rainforests and pristine beaches 
        to the dramatic mountains and glaciers. Experience the adventure and natural beauty that make this 
        destination truly unique.`, 
        price: 2800,
        duration: 12,
        image: 'images/zealand.jpg',
    },

    {
        id: 'picchu',
        name: "Mystical Machu Picchu Trek", 
        description: `Venture deep into the heart of the Andes, where you'll uncover the ancient secrets of Machu Picchu,
        the lost city of the Incas. Hike through breathtaking landscapes and immerse yourself in the rich 
        history and culture of Peru.`,
        price: 2200,
        duration: 9,
        image: 'images/machu.jpg',
    },

    {
        id: 'rio',
        name: "Vibrant Rio de Janeiro Carnival",
        description: `Experience the energy and excitement of Rio de Janeiro's world-famous Carnival, where colorful 
        parades, pulsating samba rhythms, and lively street parties 
        come together in a dazzling celebration of life.`, 
        price: 2500,
        duration: 5,
        image: 'images/rio.jpg',
    },

    {
        id: 'africa',
        name: "Majestic African Safari", 
        description: `Embark on a thrilling journey through the African wilderness,
        where you'll encounter diverse wildlife, breathtaking landscapes, and vibrant
        cultures. Discover the untamed beauty of the African savanna.`, 
        price: 3000,
        duration: 10,
        image: 'images/safari.jpg',
    },
];

const toursContainer = document.getElementById('order_tour');
toursContainer.innerHTML = '';
toursCardsData.forEach(tour => {
    const tourCard = document.createElement('div');
    tourCard.classList.add('tour-card');
    tourCard.setAttribute('id', tour.id);
    const tourImage = document.createElement('img');
    tourImage.classList.add('tour-card__image');
    tourImage.setAttribute('src', tour.image);
    tourImage.setAttribute('alt', tour.name);
    const tourTitle = document.createElement('h3');
    tourTitle.classList.add('tour-card__title');
    tourTitle.textContent = tour.name;
    const tourDescription = document.createElement('p');
    tourDescription.classList.add('tour-card__description');
    tourDescription.textContent = tour.description;
    const buttonContainer = document.createElement('div');
    buttonContainer.classList.add('tour-card__buttons');
    const buyButton = document.createElement('button');
    buyButton.classList.add('tour-card__button', 'tour-card__button-buy');
    buyButton.textContent = 'Buy Tour';
    const infoButton = document.createElement('button');
    infoButton.classList.add('tour-card__button', 'tour-card__button-info');
    infoButton.textContent = 'More Info';

    buttonContainer.appendChild(buyButton);
    buttonContainer.appendChild(infoButton);

    tourCard.appendChild(tourImage);
    tourCard.appendChild(tourTitle);
    tourCard.appendChild(tourDescription);
    tourCard.appendChild(buttonContainer);

    toursContainer.appendChild(tourCard);
});
