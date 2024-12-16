# Huffman Code Implementation in C#

This repository contains a simple implementation of Huffman coding in C#. The application provides a graphical user interface (GUI) for compressing and decompressing text using the Huffman algorithm.

## Features

*   **Compression:** Converts input text into a compressed binary representation using Huffman coding.
*   **Decompression:** Decodes a compressed binary string back to its original text form using a provided path table.
*   **Path Table Generation:** Automatically generates the path table (mapping of characters to binary codes) during compression.
*   **GUI:** User-friendly interface for easy interaction.
*   **Error Handling:** Includes checks for invalid input.

## How to Use

1.  **Clone the repository:** `git clone https://github.com/CoderAndyLive/HuffmanCode.git`
2.  **Open the solution in Visual Studio.**
3.  **Build and run the application.**
4.  **Enter text to compress or binary code and path table to decompress.**
5.  **Select the desired operation (compress or decompress).**
6.  **Click the "Start" button.**

## Code Overview

The core Huffman coding logic is implemented in the `Huffman.cs` file. Key components include:

*   **`HuffmanNode` class:** Represents a node in the Huffman tree.
*   **`HuffmanTree` class:** Handles building the Huffman tree, generating the encoding table, and provides a priority queue for node sorting.
*   **`Encode` method:** Encodes the input text.
*   **`Decompress` method:** Decodes the compressed input.
*   **`GeneratePathTable` method:** Creates the path table for mapping characters to binary codes.

## Additional Notes

*   The GUI is built using Windows Forms.
*   The application includes basic error handling for empty input and invalid characters during decompression.
*   The code is well-commented for better understanding.

Feel free to explore, modify, and use the code as needed.
