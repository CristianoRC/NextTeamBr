#pragma once

#include <string>
#include <functional>

namespace Parser {
	class Cfg {
	public:
		typedef const std::function<void(const std::string& line, const std::string& varName, const std::string& varValue)>& CALLBACK_FUNC;

		static void parse(const std::string& data, CALLBACK_FUNC callback);
	};
}