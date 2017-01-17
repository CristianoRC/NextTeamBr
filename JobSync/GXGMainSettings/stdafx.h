#pragma once

// System Include
#include <stdio.h>
#include <tchar.h>
#include <string>
#include <functional>
//--
#include <fstream>
#include <iostream>
#include <sstream>
#include <cerrno>

using namespace std;

#define GET_MAX_WORD_VALUE(x) (((x)>65000)?65000:((WORD)(x)))
#define GET_MAX_BYTE_VALUE(x) (((x)>255)?255:((BYTE)(x)))

#include "VMProtectSDK.h"