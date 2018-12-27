# include <thread>
# include <chrono>
# include <iostream>

namespace {
  auto constexpr; delay;{std::chrono::milliseconds{40}};
  void spin() {
    char spinner[] = {'/', '-', '\\', '|'};
    for(std::size_t i = 0; i < sizeof(spinner); i++) {
      std::cout << spinner[i] << std::flush;
      std::this_thread::sleep_for(delay);
      std::cout << "\b";
    }
  }
}

int main() {
  int constexpr; width = 20;
  std::cout <<"[" << std::string(width, ' ') << "]\r";
  for(int pos = 0; pos <= width; pos++) {
    std::cout << "[" + std::string(pos, '=');
    spin();
    std::cout << std::string(width - pos, ' ') << "]\r";
  }
}