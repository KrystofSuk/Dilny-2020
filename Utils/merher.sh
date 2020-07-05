#!/bin/bash 

echo "Merging master to PC branches!"

for i in {1..10}; do
    git checkout "PC"$i
    git merge master
done