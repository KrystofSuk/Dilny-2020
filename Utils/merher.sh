#!/bin/bash 

GREEN='\033[0;32m'
NC='\033[0m'

echo "Merging master to PC branches!"

for i in {1..10}; do
    echo "${GREEN}Merging master to PC$i${NC}"
    git checkout "PC"$i
    git merge master
    git push
done

git checkout "master"