document.addEventListener("DOMContentLoaded", () => {
        var button = document.getElementById("myButton")
        
        button.addEventListener("click", () => {
           
            document.body.style.backgroundColor = `rgb(${getRandomInt(0, 255)}, ${getRandomInt(0, 255)}, ${getRandomInt(0, 255)})`
            button.style.backgroundColor = `rgb(${getRandomInt(0, 255)},${getRandomInt(0, 255)},${getRandomInt(0, 255)})`
            button.style.color = `rgb(${getRandomInt(0, 255)},${getRandomInt(0, 255)},${getRandomInt(0, 255)})`

            button.textContent = randomizeText(button.textContent);
        })
    })

    function randomizeText(text) {
        // Separate the last character (exclamation mark) from the rest of the string
        let mainText = text.slice(0, -1);
        let lastChar = text.slice(-1);
    
        // Convert the main text to an array of characters
        let chars = mainText.split('');
    
        // Shuffle the array of characters
        for (let i = chars.length - 1; i > 0; i--) {
            let j = Math.floor(Math.random() * (i + 1));
            [chars[i], chars[j]] = [chars[j], chars[i]];
        }
    
        // Convert the array back to a string and append the last character
        return chars.join('') + lastChar;
    }

    function getRandomInt(min, max) {
        min = Math.ceil(min);
        max = Math.floor(max);
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }