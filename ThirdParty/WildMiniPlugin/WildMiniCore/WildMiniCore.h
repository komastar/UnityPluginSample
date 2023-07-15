//
//  File:   WildMiniCore.h
//  Author: Eugene Kim (komastar.dev@gmail.com)
//
//  Copyright (c) 2023 komastar. All rights reserved.
//

#pragma once

class WildMiniCore
{
};

extern "C" _declspec(dllexport) int CoreTest();
extern "C" _declspec(dllexport) WildMiniCore * CreateWildMiniObject();
