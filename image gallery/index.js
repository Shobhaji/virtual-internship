const imagePaths = [
  'image1.jpeg',
  'image2.jpeg',
  'image3.jpeg',


];

let currentIndex = 0;
const galleryImage = document.getElementById('galleryImage');

function changeImage(step) {
  currentIndex += step;

 
  if (currentIndex >= imagePaths.length) {
      currentIndex = 0;
  } else if (currentIndex < 0) {
      currentIndex = imagePaths.length - 1;
  }

  const imagePath = imagePaths[currentIndex];
  galleryImage.src = imagePath;
}


changeImage(0);