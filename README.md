# AeroCatalog

A simple static aircraft catalog website built for class using HTML,
CSS and Bootstrap 5. No build tools, no database, no JavaScript
frameworks - just plain HTML pages linked together.

## What's here

- `index.html` - home page with a 4-slide carousel and a catalog
  table of 10 sample aircraft.
- `faqs.html` - FAQ accordion (placeholder text for now).
- `about.html` - About page (placeholder text for now).
- `aircraft/` - one detail page per aircraft (10 files).
- `css/styles.css` - small custom stylesheet on top of Bootstrap.

## Running it

Open `index.html` in any modern browser. That's it.

## Images (Azure Blob Storage)

All `<img>` tags use URLs in this form:

```
https://<yourstorageaccount>.blob.core.windows.net/aircraft/<slug>.jpg
```

To make the images show up:

1. Create a storage account in Azure.
2. Create a container called `aircraft` (public read).
3. Upload the images using the same slug as the detail page
   filename, e.g. `skyhawk-100.jpg`, `condor-300.jpg`, etc.
4. In every HTML file, replace `<yourstorageaccount>` with your
   actual Azure storage account name.

Each `<img>` tag has a short comment above it reminding you to do
this.

## Notes

- The navbar and footer are copy-pasted across every page. If you
  change them in one place, remember to update the others.
- The catalog submenu (under "Catalog" in the navbar) lists all
  10 aircraft so any detail page is one click away from anywhere.
- Everything is responsive thanks to Bootstrap's grid and the
  `img-fluid` class on images.
