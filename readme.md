Watermark folder
===============

## Description
This bash script basically create a watermark document, and apply it to every .pdf document of the specified folder
This is very convenient you need to hand over multiple sensitive documents to an organism, and protect your data from being stolen/misused.

## Prerequisites
- Ghostscript: to create the watermark file
- pdftk: to apply the watermark to every documents

## Usage
watermark_folder.sh <input_folder_path> <watermark_text>

## Output
The script will create a folder named <watermark_text> inside the <input_folder> folder, containing every .pdf document of <input_folder> with applied watermark.
It will also place the watermark file used in <input_folder>/watermark folder.


