document.addEventListener("DOMContentLoaded", () => {
        var button = document.getElementById("myButton");
        let label = document.getElementById("myLabel");

        button.addEventListener("click", () => {
           
            document.body.style.backgroundColor = `rgb(${getRandomInt()}, ${getRandomInt()}, ${getRandomInt()})`
            button.style.backgroundColor = `rgb(${getRandomInt()},${getRandomInt()},${getRandomInt()})`
            button.style.color = `rgb(${getRandomInt()},${getRandomInt()},${getRandomInt()})`

            button.textContent = randomizeText(button.textContent);

            label.textContent++;
            label.style.color = `rgb(${getRandomInt()},${getRandomInt()},${getRandomInt()})`;

        })
    })

    function randomizeText(text) {
        let mainText = text.slice(0, -1);
        let lastChar = text.slice(-1);

        let chars = mainText.split('');
    
        for (let i = chars.length - 1; i > 0; i--) {
            let j = Math.floor(Math.random() * (i + 1));
            [chars[i], chars[j]] = [chars[j], chars[i]];
        }
    
        return chars.join('') + lastChar;
    }

    function getRandomInt() {
        let min = Math.ceil(0);
        let max = Math.floor(255);
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }