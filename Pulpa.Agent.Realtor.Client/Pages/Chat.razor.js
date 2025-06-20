export function chatScrollToBottom(element) {
    if (element) {
        element.scrollTop = element.scrollHeight;
    }
};