const BASE_URL = "https://api.thecatapi.com/v1/images/search";
const img = document.getElementById('cat');
const btn = document.getElementById('change-cat');

const getCats = async () => {
	try {
		const data = await fetch(BASE_URL);
		const json = await data.json();
		return json[0].url;
	} catch (e) {
		console.log(e.message);
	}
};

const loadImg = async () => {
	img.src = await getCats();
};

loadImg();

btn.addEventListener('click', loadImg);