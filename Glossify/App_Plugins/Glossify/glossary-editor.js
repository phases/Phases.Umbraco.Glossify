document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('.glossary-term').forEach(function (term) {
        term.addEventListener('mouseenter', function (e) {
            document.querySelectorAll('.glossary-tooltip').forEach(function (t) { t.remove(); });

            var definition = this.getAttribute('data-glossary-definition');
            if (definition) {
                var tooltip = document.createElement('div');
                tooltip.className = 'glossary-tooltip';
                tooltip.textContent = definition;
                this.appendChild(tooltip);
            }
        });

        term.addEventListener('mouseleave', function () {
            var tooltip = this.querySelector('.glossary-tooltip');
            if (tooltip) tooltip.remove();
        });
    });
});