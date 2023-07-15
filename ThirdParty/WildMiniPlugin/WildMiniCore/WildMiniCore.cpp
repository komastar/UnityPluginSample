//
//  File:   WildMiniCore.cpp
//  Author: Eugene Kim (komastar.dev@gmail.com)
//
//  Copyright (c) 2023 komastar. All rights reserved.
//

#include "WildMiniCore.h"

int CoreTest()
{
    static int i = 0;
    return i++;
}

WildMiniCore* CreateWildMiniObject()
{
    return new WildMiniCore();
}
