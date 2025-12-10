# Phases.Umbraco.Glossify

A simple and powerful way to add glossary tooltips inside the Umbraco Rich Text Editor (RTE).

Supports Umbraco versions 10–13.

Glossify extends the default Umbraco RTE by adding:

- **Glossary Link** — pick a glossary node and apply a tooltip
- **Clear Glossary** — remove an existing glossary tooltip

## ✨ Features

- Adds a custom Glossary Link button to the Umbraco RTE
- Adds a Clear Glossary button
- Allows editors to select any RTE text and link it to a glossary definition
- Highlights glossary-linked text directly in the CMS
- Displays the chosen definition on hover/tap on the frontend
- Simple FE integration for styles and scripts

## 📦 Installation

1. Install the Glossify package.
2. Go to **Settings → Rich Text Editor**.
3. Enable the two new toolbar options:
   - **Glossary Link**
   - **Clear Glossary**
4. Save your RTE configuration.

## 📝 How to Use (CMS)

1. Open any RTE content editor.
2. Select the text you want to add a glossary tooltip to.
3. Click **Glossary Link**.
4. Choose the glossary node containing the definition.
   - The property alias for the definition must be: `definition`
5. The selected text will be highlighted inside the CMS editor.

To remove a glossary tooltip:

1. Select the linked text
2. Click **Clear Glossary**
3. Save & publish

## 🌐 Frontend Setup

After installing the package, two frontend files will be available in:

```
/app_plugins/Glossify/
```

Make sure to include them in your layout/page:

```html
<link href="~/app_plugins/Glossify/glossary-editor.css" rel="stylesheet" />
<script src="~/app_plugins/Glossify/glossary-editor.js"></script>
```

Rendering these in your page will:

- Apply the highlighting style
- Enable tooltip behavior
- Display the selected term's definition on hover or tap

## ✔ Result

With Phases.Umbraco.Glossify enabled:

- Editors can add glossary tooltips in seconds
- Site visitors see clean, interactive definitions by hovering or tapping
- All definitions stay managed inside Umbraco


