async function addNewComment() {
    const response = await fetch("/Home/AddCommentPartial");
    const message = await response.text();
    document
        .getElementById("newCommentId")
        .insertAdjacentHTML("beforeend", message);
}