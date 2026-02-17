// ── Mobile Navigation Toggle ──
document.addEventListener('DOMContentLoaded', function () {
    const navToggle = document.getElementById('navToggle');
    const navMenu = document.getElementById('navMenu');

    if (navToggle && navMenu) {
        navToggle.addEventListener('click', function () {
            const isOpen = navMenu.classList.contains('flex');
            if (isOpen) {
                navMenu.classList.add('hidden');
                navMenu.classList.remove('flex', 'flex-col');
                navToggle.setAttribute('aria-expanded', 'false');
            } else {
                navMenu.classList.remove('hidden');
                navMenu.classList.add('flex', 'flex-col');
                navToggle.setAttribute('aria-expanded', 'true');
            }
        });

        // Close mobile nav when clicking a link
        navMenu.querySelectorAll('a').forEach(function (link) {
            link.addEventListener('click', function () {
                if (window.innerWidth < 1280) {
                    navMenu.classList.add('hidden');
                    navMenu.classList.remove('flex', 'flex-col');
                    navToggle.setAttribute('aria-expanded', 'false');
                }
            });
        });
    }
});

// ── Accordion ──
document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('[data-accordion]').forEach(function (accordion) {
        const parentMode = accordion.hasAttribute('data-accordion-parent');

        accordion.querySelectorAll('[data-accordion-toggle]').forEach(function (btn) {
            btn.addEventListener('click', function () {
                const targetId = this.getAttribute('data-accordion-target');
                const panel = document.getElementById(targetId);
                if (!panel) return;

                const icon = this.querySelector('.accordion-toggle-icon');
                const isCollapsed = panel.classList.contains('collapsed');

                if (parentMode) {
                    // Close all others in this accordion
                    accordion.querySelectorAll('.accordion-panel').forEach(function (p) {
                        p.classList.add('collapsed');
                    });
                    accordion.querySelectorAll('[data-accordion-toggle]').forEach(function (b) {
                        b.setAttribute('aria-expanded', 'false');
                        var ic = b.querySelector('.accordion-toggle-icon');
                        if (ic) ic.classList.remove('rotated');
                    });
                }

                if (isCollapsed) {
                    panel.classList.remove('collapsed');
                    this.setAttribute('aria-expanded', 'true');
                    if (icon) icon.classList.add('rotated');
                } else {
                    panel.classList.add('collapsed');
                    this.setAttribute('aria-expanded', 'false');
                    if (icon) icon.classList.remove('rotated');
                }
            });
        });
    });

    // ── Toggle All Button (FAQ page) ──
    const toggleBtn = document.getElementById('toggleAllBtn');
    const faqAccordion = document.getElementById('faqAccordion');

    if (toggleBtn && faqAccordion) {
        let allExpanded = true; // FAQ starts with all expanded

        toggleBtn.addEventListener('click', function () {
            const panels = faqAccordion.querySelectorAll('.accordion-panel');
            const buttons = faqAccordion.querySelectorAll('[data-accordion-toggle]');

            if (allExpanded) {
                panels.forEach(function (p) { p.classList.add('collapsed'); });
                buttons.forEach(function (b) {
                    b.setAttribute('aria-expanded', 'false');
                    var ic = b.querySelector('.accordion-toggle-icon');
                    if (ic) ic.classList.remove('rotated');
                });
                toggleBtn.textContent = 'Expand All';
                allExpanded = false;
            } else {
                panels.forEach(function (p) { p.classList.remove('collapsed'); });
                buttons.forEach(function (b) {
                    b.setAttribute('aria-expanded', 'true');
                    var ic = b.querySelector('.accordion-toggle-icon');
                    if (ic) ic.classList.add('rotated');
                });
                toggleBtn.textContent = 'Collapse All';
                allExpanded = true;
            }
        });

        // Keep button text in sync when individual items are toggled
        faqAccordion.addEventListener('click', function (e) {
            const btn = e.target.closest('[data-accordion-toggle]');
            if (!btn) return;
            setTimeout(function () {
                const panels = faqAccordion.querySelectorAll('.accordion-panel');
                const expanded = faqAccordion.querySelectorAll('.accordion-panel:not(.collapsed)');
                if (expanded.length === panels.length) {
                    toggleBtn.textContent = 'Collapse All';
                    allExpanded = true;
                } else if (expanded.length === 0) {
                    toggleBtn.textContent = 'Expand All';
                    allExpanded = false;
                } else {
                    toggleBtn.textContent = 'Collapse All';
                    allExpanded = true;
                }
            }, 50);
        });
    }
});
