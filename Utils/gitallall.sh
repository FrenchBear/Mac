#!/bin/bash

pushd ~/Development >/dev/null
cd GitVSTS
gitall.sh $@
echo After GitVSTS
pwd
cd ../GitHub
gitall.sh $@
popd >/dev/null
