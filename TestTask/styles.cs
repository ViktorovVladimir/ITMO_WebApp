/* styles.css */

/* 1. Using a gradient for the background */
body 
{
    background: linear-gradient(to right, #ff7e5f, #feb47b);
    font-family: Arial, sans-serif;
}

/* 2. Applying shadows to titles */
h1, h2 
{
    text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.5);
}

/* +3. Rounding corners for buttons */
button 
{
    background-color: #4CAF50; 				/* Green background */
    border: none;
    color: white;
    padding: 15px 32px;
    text-align: center;
    text-decoration: none;
    display: inline-block;
    font-size: 16px;
    margin: 4px 2px;
    cursor: pointer;
    border-radius: 12px; 					/* Rounded corners */
}

/* 4. Using Transform for Hover Effects */
nav ul li a 
{
    transition: transform 0.3s ease; 		/* Smooth transition */
}

nav ul li a:hover 
{
    transform: scale(1.1); 					/* Zoom on hover */
}

/* 5. Using Flexbox to Align Elements in Navigation */
nav ul 
{
    display: flex; 							/* Flexbox for horizontal alignment */
    list-style-type: none; 					/* Removing list markers */
}

nav ul li 
{
    margin-right: 20px; 					/* Padding between navigation elements */
}

/* Additional styles for the footer */
footer 
{
    text-align: center; 					/* Centering text */
    padding: 20px;
    background-color: rgba(0, 0, 0, 0.8); 	/* Transparent background */
    color: red; 							/* White text */
}