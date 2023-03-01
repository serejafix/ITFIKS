async function addNewTag() {
    const response = await fetch("/Home/AddTagPartial");
    const message = await response.text();
    document
        .getElementById("newTagId")
        .insertAdjacentHTML("beforeend", message);
}