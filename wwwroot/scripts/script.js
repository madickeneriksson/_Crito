document.getElementById("contactForm").addEventListener("submit", function (e) {
    const nameField = document.getElementById("name");
    const emailField = document.getElementById("email");
    const messageField = document.getElementById("message");

    if (nameField.value.length < 2) {
        alert("Name must be at least 2 characters.");
        e.preventDefault(); // Förhindra formuläret från att skickas
    }

    if (!isValidEmail(emailField.value)) {
        alert("Invalid email address.");
        e.preventDefault(); // Förhindra formuläret från att skickas
    }

    if (messageField.value.length < 5) {
        alert("Message must be at least 5 characters.");
        e.preventDefault(); // Förhindra formuläret från att skickas
    }
});

function isValidEmail(email) {
    // Enkel e-postvalidering med ett reguljärt uttryck (regex)
    const emailRegex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
    return emailRegex.test(email);
}
