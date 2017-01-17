#pragma once
#include "Sii.hpp"
#include "..\Main.h"
#include <string>
#include <vector>
#include <functional>

namespace Parser::Sii {
	class Text {
	public:
		static bool parse(const std::string& data, const ParseCallback& callback);
	};
}
