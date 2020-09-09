#!/bin/bash

usage() {
	echo "Usage: $0 <input_folder_path> <watermark_text>"
	echo "Watermark every pdf files in folder"
	exit
}

if [ $# -ne 2 ]
then
	usage
fi

if [ ! -d $1 ]
then
	echo "Error: input_folder: $1 not found"
	usage
fi

input_folder=$1
watermark_text=${2//\ /_}
output_folder="$input_folder/$watermark_text"
watermark_file="$input_folder/watermark/${watermark_text}.pdf"
eps_file=$(mktemp)
angle=45 # in degrees counterclockwise from horizontal
grey=0.75 # 0 is black 1 is white
watermark_text_length=${#watermark_text}

trap "rm -f $eps_file" EXIT

if [ -d $output_folder ]
then
	rm -r $output_folder
fi
mkdir $output_folder

if [ ! -d "$input_folder/watermark" ]
then
	mkdir "$input_folder/watermark"
fi

# Create eps file to generate pdf watermark
cat <<EOF > $eps_file
%!PS
/cm { 28.4 mul } bind def
/draft-Bigfont /Helvetica-Bold findfont $((72*15/$watermark_text_length)) scalefont def
/draft-copy {
        gsave initgraphics $grey setgray
        4 cm 8 cm moveto
        $angle rotate
        draft-Bigfont setfont
        ($watermark_text) show grestore
 } def
draft-copy showpage
EOF

# Generate pdf watermark
ps2pdf $eps_file $watermark_file

# Watermark on every pdf of $input_folder
find "$input_folder" -maxdepth 1 -type f -iname "*.pdf" | while IFS= read file_path; do
	file_name=`echo $(basename "$file_path")`
	if [ "$filename" = "${watermark_text}.pdf" ]
	then
		continue
	fi
        pdftk "${file_path}" stamp "$watermark_file" output "$output_folder/$file_name"
done

rm -f $eps_file
