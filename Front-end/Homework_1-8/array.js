//Task I - Array of tour objects
const tours = [
    {
        Name: "Mystical Bali Adventure",
        description: `Explore the enchanting island of Bali, with its lush jungles, vibrant culture, and ancient temples.
        Visit the iconic Tanah Lot temple, hike to the summit of Mount Batur, and unwind on the pristine
        beaches of Nusa Dua.`,
        price: 2000,
        duration: 7,
    },

    {
        Name: "Futuristic Tokyo Odyssey",
        Description: `Discover the captivating blend of tradition and innovation in Tokyo. 
        Experience the city's bustling streets and neon-lit nights, visit ancient temples and shrines, 
        and savor the exquisite flavors of Japanese cuisine.`,
        Price: 2000,
        Duration: 7,
    },

    {
        Name: "Alaskan Wilderness Expedition", 
        Description: `Immerse yourself in the rugged beauty of Alaska, a land of towering mountains, 
        pristine glaciers, and lush forests. Explore untouched wilderness, witness awe-inspiring wildlife, 
        and experience unforgettable adventures.`, 
        Price: 3500,
        Duration: 10,
    },

    {
        Name: "Enigmatic Egyptian Odyssey", 
        Description: `Uncover the mysteries of ancient Egypt, from the iconic pyramids and Sphinx to the bustling 
        markets and vibrant cities along the Nile River. Delve into the history, art, and culture that have 
        captivated the world for millennia.`,
        Price: 1800,
        Duration: 8,
    },

    {
        Name: "Scenic New Zealand Adventure", 
        Description: `Traverse the stunning landscapes of New Zealand, from the lush rainforests and pristine beaches 
        to the dramatic mountains and glaciers. Experience the adventure and natural beauty that make this 
        destination truly unique.`, 
        Price: 2800,
        Duration: 12,
    },

    {
        Name: "Mystical Machu Picchu Trek", 
        Description: `Venture deep into the heart of the Andes, where you'll uncover the ancient secrets of Machu Picchu,
        the lost city of the Incas. Hike through breathtaking landscapes and immerse yourself in the rich 
        history and culture of Peru.`,
        Price: 2200,
        Duration: 9,
    },

    {
        Name: "Vibrant Rio de Janeiro Carnival",
        Description: `Experience the energy and excitement of Rio de Janeiro's world-famous Carnival, where colorful 
        parades, pulsating samba rhythms, and lively street parties 
        come together in a dazzling celebration of life.`, 
        Price: 2500,
        Duration: 5,
    },

    {
        Name: "Majestic African Safari", 
        Description: `Embark on a thrilling journey through the African wilderness,
        where you'll encounter diverse wildlife, breathtaking landscapes, and vibrant
        cultures. Discover the untamed beauty of the African savanna.`, 
        Price: 3000,
        Duration: 10,
    },
];

//Task II - Sort by max cost 2500
const sortedToursByCost = tours.filter((element) => {
        return element.Price <= 2500;
});
console.log(sortedToursByCost);

//Task III - Sort by name
const sortedToursByName = tours.sort((a,b) => a.Name.localeCompare(b.Name));
console.log(sortedToursByName);