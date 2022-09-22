 (() => {
    const i = setInterval(() => {
      [...document.querySelectorAll('.models [aria-expanded="false"]')].map((el) =>
        el.click()
      ).length || clearInterval(i);
    }, 1000);
})();
