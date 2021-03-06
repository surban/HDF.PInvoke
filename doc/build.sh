#!/bin/bash

VERSION="2.42.4"

set -e
pushd "$(dirname "${BASH_SOURCE[0]}")" 

if [ ! -d docfx ]; then
    mkdir -p docfx
    pushd docfx
    nuget install docfx.console -ExcludeVersion -Version $VERSION
    popd
fi

mono docfx/docfx.console/tools/docfx.exe

popd
