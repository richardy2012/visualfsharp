// #Conformance #LexicalAnalysis 
#light

// Verify getting the byte value of a char works past the first 128 ASCII characters

if 'ú'  <> '\250' then exit 1

exit 0